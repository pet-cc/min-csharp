using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using DAL;

namespace aplicacao
{
    class Program{
        static void Main(string[] args){
            /*using (var reader = new StreamReader(@"C:\Users\Administrador\Desktop\min-csharp-master\min-csharp-master\dia2\cidade.csv")){
                while (!reader.EndOfStream){
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Cidade cid = new Cidade();
                    cid.CID_NOME = values[0];
                    cid.CID_UF = values[1];
                    CidadeDAL dal = new CidadeDAL();
                    dal.Insert(cid);
                }
            }*/
            CidadeDAL dal = new CidadeDAL();
            List<Cidade> lscid = dal.Select();
            lscid.Where(x => x.CID_UF == "RS").ToList().ForEach(x => {
                Console.WriteLine(x.CID_NOME);
            });
            Console.ReadKey();
        }
    }
}
