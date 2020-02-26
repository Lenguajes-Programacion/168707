using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace PracticaDos
{
    class Memoria
    {
        public void leerMemoria()
        {
            string arcivoDB = "../../../db.json";
            StreamReader reader = new StreamReader(arcivoDB);
            var dbJSON = reader.ReadToEnd();
            JObject dbObject = JObject.Parse(dbJSON);
                //Prueba de lectura de archivo db json
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
                //lectura iterable de archivo db json
            foreach (var item in dbObject)
            {
                Console.WriteLine("dato en memoria");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now.ToString(), item.Value["operacion"].ToString(),  item.Value["resultado"].ToString());
                Console.WriteLine(memoriaData.fecha.ToLongDateString(),
                memoriaData.fecha.ToLongTimeString());
                Console.WriteLine(item.Key.ToString());
                Console.WriteLine(memoriaData.resultado.ToString());
            }

        }
    }

    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData(String date, String operation, String result)
        {
            fecha = 
                
                DateTime.Parse(date);
            operacion = operation;
            resultado = int.Parse(result);
        }

    }
}
