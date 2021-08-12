using System;
using System.Collections.Generic;

namespace PruebaOrdenListas
{
    class Program
    {
        static void Main(string[] args)
        {
			List<JerarquiaCls> Jerarquias = new List<JerarquiaCls>
	{
		new JerarquiaCls {id = 1, cargo = "Embajador" },
		new JerarquiaCls {id = 2, cargo = "Ministro" },
		new JerarquiaCls {id = 3, cargo = "Ministro Consejero" },
		new JerarquiaCls {id = 4, cargo = "Consejero" },
		new JerarquiaCls {id = 5, cargo = "Primer Secretario" },
		new JerarquiaCls {id = 6, cargo = "Segundo Secretario" },
		new JerarquiaCls {id = 7, cargo = "Tercer Secretario" },
		new JerarquiaCls {id = 8, cargo = "Agregado" }
	};

			//Dictionary<int,string> jerarquia = new Dictionary<int, string>();
			//		jerarquia.Add(1,"Embajador");
			//	    jerarquia.Add(2,"Ministro");
			//		jerarquia.Add(3,"MinistroConsejero");
			//	    jerarquia.Add(4,"Consejero");
			//	    jerarquia.Add(5,"PrimerSecretario");
			//	    jerarquia.Add(6,"SegundoSecretario");
			//	    jerarquia.Add(7,"TercerSecretario");
			//	    jerarquia.Add(8,"Agregado");


			List<Test> Unsorted = new List<Test>
	{
		new Test { nid = "7E10003", nombre = "Cuarto" ,cargo = "Primer Secretario" },
		new Test { nid = "7E10002", nombre = "Tercero" ,cargo = "Consejero"},
		new Test { nid = "7E10000", nombre = "Primero" ,cargo = "Embajador"},
		new Test { nid = "7E10001", nombre = "Segundo" ,cargo = "Ministro"}
	};
			List<Test> Sorted = new List<Test>();
			
			foreach (JerarquiaCls item in Jerarquias)
			{
				foreach (Test x in Unsorted)
				{
					var existe = item.ExisteEn(Sorted, x);
					if (!existe)
					{
						if (x.cargo == item.cargo)
						{
							Sorted.Add(x);
						}
					
					}
				}
			};

			foreach (var x in Sorted)
            {
				Console.WriteLine(x.nid + " - " + x.nombre + " - " + x.cargo);
			};

			Console.ReadKey();
		}

        
    }

	class Test
	{
		public string nid { get; set; }
		public string nombre { get; set; }
		public string cargo { get; set; }
	};

	class JerarquiaCls
	{
		public int id { get; set; }
		public string cargo { get; set; }
		public Boolean ExisteEn(List<Test> lista, Test item)
		{
			foreach (var x in lista)
			{
				if (x.cargo == item.cargo)
				{ return true; }
			}

			return false;


		}
	};
}

