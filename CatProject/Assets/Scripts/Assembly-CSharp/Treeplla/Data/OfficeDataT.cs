using System.Collections.Generic;
using Newtonsoft.Json;

namespace Treeplla.Data
{
	public class OfficeDataT
	{
		[JsonProperty("office")]
		public int Office { get; set; }

		[JsonProperty("company")]
		public int Company { get; set; }

		[JsonProperty("items")]
		public List<OfficeItemDataT> Items { get; set; }

		[JsonProperty("isopend")]
		public bool Isopend { get; set; }

		[JsonProperty("opencompletetime")]
		public long Opencompletetime { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("exp")]
		public int Exp { get; set; }

		[JsonProperty("companyendtime")]
		public long Companyendtime { get; set; }

		[JsonProperty("employees")]
		public List<EmployeeDataT> Employees { get; set; }

		[JsonProperty("maintenancetime")]
		public long Maintenancetime { get; set; }

		[JsonProperty("inmaintenance")]
		public bool Inmaintenance { get; set; }

		[JsonProperty("inrepair")]
		public bool Inrepair { get; set; }

		[JsonProperty("lastrepairtime")]
		public long Lastrepairtime { get; set; }

		[JsonProperty("manager")]
		public int Manager { get; set; }

		[JsonProperty("onnegotiation")]
		public bool Onnegotiation { get; set; }
	}
}
