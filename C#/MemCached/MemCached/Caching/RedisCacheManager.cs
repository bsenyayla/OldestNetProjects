using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemCached.Caching {



    public class RedisCacheManager : AbstractCacheProvider<ConnectionMultiplexer> {
        public static System.Net.WebClient WebClient = new System.Net.WebClient();
        private static readonly object SyncObject = new object();
        private static volatile RedisCacheManager _instance;
        private readonly IDatabase _redisDb;
        private ConnectionMultiplexer _redis;

        private static System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = null;
        public static System.Web.Script.Serialization.JavaScriptSerializer JavaScriptSerializer {
            get {
                if (javaScriptSerializer == null) javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                return javaScriptSerializer;
            }
        }
        private static LigTvServiceReference.DataServiceClient dataServiceClient = null;
        public static LigTvServiceReference.DataServiceClient DataServiceClient {
            get {
                if (dataServiceClient == null) dataServiceClient = new LigTvServiceReference.DataServiceClient();
                return dataServiceClient;
            }
        }
        private static LigTvServiceReference.ServiceClient theServiceClient = null;
        public static LigTvServiceReference.ServiceClient TheServiceClient {
            get {
                if (theServiceClient == null) {
                    theServiceClient = new LigTvServiceReference.ServiceClient();
                    theServiceClient.UserName = "LigtvHbbTv";
                    theServiceClient.Password = "L19Tv#HbbTv!";
                }
                return theServiceClient;
            }
        }

        public RedisCacheManager() {
            if (_redis != null) {
                _redisDb = _redis.GetDatabase();
            }
        }

        public static RedisCacheManager Instance() {
            if (_instance == null) {
                lock (SyncObject) {
                    if (_instance == null) {
                        _instance = new RedisCacheManager();
                    }
                }
            }

            return _instance;
        }

        public override bool Exists(string key) {
            try {
                return _redisDb.KeyExists(key);
            }
            catch (Exception ex) {
                LogManager.Log(new LogModel {
                    Message = "Redis.Exists",
                    Exception = ex
                });
            }

            return false;
        }

        public override bool Get<T>(string key, out T value) {
            value = default(T);

            //if (ConfigurationFactory.AwsEndpointConfiguration().IsOpenRedisCache != 1) return false;

            try {
                if (Exists(key)) {
                    value = JsonConvert.DeserializeObject<T>(_redisDb.StringGet(key));
                    return true;
                }
            }
            catch (Exception ex) {
                LogManager.Log(new LogModel {
                    Message = "Redis.Get<T>",
                    MessageDetail = string.Format("{0}{1}", "Get<T>(string key):", key),
                    Exception = ex
                });
            }

            return false;
        }

        public override void Set<T>(string key, T value) {
            try {
                //if (ConfigurationFactory.AwsEndpointConfiguration().IsOpenRedisCache != 1) return;
                //Set(key, value, CacheDuration);
                _redisDb.StringSet(key, JsonConvert.SerializeObject(value));
            }
            catch (Exception ex) {
                LogManager.Log(new LogModel {
                    Message = "Redis.Set<T>",
                    MessageDetail = "Set<T>(string key, T value)",
                    Exception = ex
                });
            }
        }

        public override void Set<T>(string key, T value, double duration) {
            try {
                //if (ConfigurationFactory.AwsEndpointConfiguration().IsOpenRedisCache != 1) return;
                _redisDb.StringSet(key, JsonConvert.SerializeObject(value), DateTime.Now.AddMinutes(duration).ToUniversalTime().Subtract(DateTime.UtcNow));
            }
            catch (Exception ex) {
                LogManager.Log(new LogModel {
                    Message = "Redis.Set<T>",
                    MessageDetail = "Set<T>(string key, T value, int duration",
                    Exception = ex
                });
            }
        }

        public override void Delete(string key) {
            try {
                if (Exists(key)) {
                    _redisDb.KeyDelete(key);
                }
            }
            catch (Exception ex) {
                LogManager.Log(new LogModel {
                    Message = "Redis.Delete",
                    Exception = ex
                });
            }
        }

        public override List<string> GetAllKeys(string prefix) {
            List<string> keyList = null;

            try {
                //var server = _redis.GetServer("basiciqdz.thoggc.0001.euw1.cache.amazonaws.com:6379");
                var server = _redis.GetServer(System.Configuration.ConfigurationManager.AppSettings.Get("Cache"));
                var pattern = string.Format("{0}*", prefix);
                var keys = server.Keys(pattern: pattern);
                var redisKeys = keys as RedisKey[] ?? keys.ToArray();

                if (keys == null || !redisKeys.Any()) return null;

                keyList = redisKeys.Select(key => (string)key).ToList();
            }
            catch (Exception ex) {
                LogManager.Log(new LogModel {
                    Message = "Redis.GetAllKeys",
                    Exception = ex
                });
            }

            return keyList;
        }

        protected override ConnectionMultiplexer InitCache() {
            if (_redis == null) {
                lock (SyncObject) {
                    if (_redis == null) {
                        //_redis = ConnectionMultiplexer.Connect("basiciqdz.thoggc.0001.euw1.cache.amazonaws.com:6379" + ",syncTimeout=5000,connectTimeout=2000,abortConnect=false");
                        _redis = ConnectionMultiplexer.Connect(System.Configuration.ConfigurationManager.AppSettings.Get("Cache") + ",syncTimeout=5000,connectTimeout=2000,abortConnect=false");
                    }
                }
            }

            return _redis;
        }
    }
}