using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MemCached {
	class YeniClass {

		private static String connStrRemoteTestDb = "server=10.234.95.151;port=3306;database=galatadbtest_v1.2;uid=sa;password=Tq{C.eJss%8F9$z-;";
		private static MySqlConnection _conn;
		private static MySqlCommand _cmd;
		private static string sqlInsert = @"
INSERT INTO `galatadbtest_v1.2`.`mst_products` 
	( 
	`Prd_COr_Id_Ref`, 
	`Prd_Code_Lcl`, 
	`Prd_Name_Lcl`, 
	`Prd_Code_Int`, 
	`Prd_Name_Int`, 
	`Prd_Class_Main_Code_Int`, 
	`Prd_Class_Main_Code_Lcl`, 
	`Prd_Class_Brand_Code`, 
	`Prd_Class_Web_Code`, 
	`_Created`, 
	`_CreatedBy`, 
	`_Modified`, 
	`_ModifiedBy`, 
	`_Cancelled`, 
	`_Status`, 
	`Prd_Auxiliary_Code1`, 
	`Prd_Auxiliary_Code2`, 
	`Prd_Auxiliary_Code3`, 
	`Prd_Auxiliary_Code4`, 
	`Prd_Auxiliary_Code5`, 
	`Prd_Short_Name`, 
	`Prd_Product_Type`, 
	`Prd_Entry_Date`, 
	`Prd_Exit_Date`, 
	`Prd_isSaleable`, 
	`Prd_PUD_Default_Sales_Unit_Id_Ref`, 
	`Prd_PUD_Min_Sales_Unit_Id_Ref`, 
	`Prd_PUD_Max_Sales_Unit_Id_Ref`, 
	`Prd_isPromotional_Product`, 
	`Prd_VAT_Rate1`, 
	`Prd_VAT_Rate2`, 
	`Prd_VAT_Rate3`, 
	`Prd_Description`, 
	`Prd_HasDistRight`, 
	`Prd_Search_Keyword`, 
	`Prd_Brand_Code`, 
	`Prd_SPU_Code`, 
	`Prd_SPU_Order_Nr`, 
	`Prd_Web_Active`, 
	`Prd_Source_Hierarchy_Code`, 
	`Prd_Source_Name`, 
	`Prd_New_Flag_Exit_Date`
	)
	VALUES
	(
	'1', 
	'20021492', 
	'bsenyayla V3 - memory table - temizlenmiş kod ile', 
	NULL, 
	NULL, 
	NULL, 
	'002.002.002.001.002.004.001.023.002', 
	'004.007', 
	'004.007', 
	NOW(), 
	-9, 
	NULL, 
	NULL, 
	NULL, 
	0, 
	NULL, 
	NULL, 
	NULL, 
	NULL, 
	NULL, 
	'LIPTON ADACAYI', 
	2, 
	CURDATE(), 
	CURDATE(), 
	1, 
	1, 
	1, 
	1, 
	2, 
	8, 
	9, 
	7, 
	'Bahadır Test - Bahadır Test -Bahadır Test', 
	0, 
	'Bahadır Test', 
	15, 
	'20022117', 
	0, 
	NULL, 
	NULL, 
	NULL, 
	NULL
	);


";


		public static MySqlConnection ActiveConn {
			get {
				if (_conn == null) {
					_conn = new MySqlConnection(connStrRemoteTestDb);
					_conn.Open();
				}

				return _conn;
			}

		}

		public static MySqlCommand ActiveCmd {
			get {
				if (_cmd == null) {
					_cmd = ActiveConn.CreateCommand();
					_cmd.CommandTimeout = 0;
				}

				return _cmd;
			}
		}


		public static void WriteToProduct() {


			using (MySqlCommand cmd = ActiveConn.CreateCommand()) {
				cmd.CommandTimeout = 0;
				cmd.CommandText = sqlInsert;
				cmd.ExecuteNonQuery();
			}
		}
	}
}
