using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Entidades;
using DAL;

namespace aplicacao
{
    class Program{
        static void Main(string[] args){
            CidadeDAL dal = new CidadeDAL();
            //using (var reader = new StreamReader(@"CAMINHO\cidade.csv")){
            //    while (!reader.EndOfStream){
            //        var line = reader.ReadLine();
            //        var values = line.Split(',');
            //        Cidade cid = new Cidade
            //        {
            //            CID_NOME = values[0],
            //            CID_UF = values[1]
            //        };
            //        dal.Insert(cid);
            //    }
            //}
            List<Cidade> lscid = dal.Select();

            foreach(var t in lscid){
                Console.WriteLine(t.CID_NOME);
            }

            //IEnumerable<Cidade> sel = from cid in lscid
            //                   where cid.CID_UF.Equals("RS")
            //                   select cid;
            //lscid.Where(x => x.CID_UF == "RS").ToList().ForEach(x => {
            //    Console.WriteLine(x.CID_NOME);
            //});

            Console.ReadKey();
        }
    }
}
