
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    class PemrosesData {
        public void DapatkanNilaiTerbesar<xT, yT, zT>(xT nilai1, yT nilai2, zT nilai3)
        {
            dynamic nilaiTerbesar = 0;

           for (int i = 0; i < 3; i++){
                if (nilai1 > nilaiTerbesar)
                {
                    nilaiTerbesar = nilai1;
                }
                else if (nilai2 > nilaiTerbesar)
                {
                    nilaiTerbesar = nilai2;
                }
                else if (nilai3 > nilaiTerbesar)
                {
                    nilaiTerbesar = nilai3;
                }
            } 

            Console.WriteLine(nilaiTerbesar);
        }
    }

    class SimpleDataBase<T> {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase() {
          storedData = new List<T>();
          inputDates = new List<DateTime>();
        }

        public void AddNewData(T data) { 
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData() {
            for (int i = 0; i < storedData.Count; i++) {
                Console.WriteLine($"Data {i+1} berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }


    static void Main()
    {
        PemrosesData data = new PemrosesData();
        data.DapatkanNilaiTerbesar<double, double, double>(10, 30, 22);

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
    }

}

