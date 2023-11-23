using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPro
{
    public class DataClass
    {
        private struct PizzaData
        {
            public string Name;
            public int Price;
            public int Count;
        }

        private List<PizzaData> pizzaDataList = new List<PizzaData>();

        public DataClass() 
        {
            PizzaData pizzaDataTmp = new PizzaData();
            pizzaDataTmp.Name = "Мортаделла с песто";
            pizzaDataTmp.Price = 519;
            pizzaDataTmp.Count = 0;
            pizzaDataList.Add(pizzaDataTmp);

            pizzaDataTmp.Name = "Пицца из половинок";
            pizzaDataTmp.Price = 320;
            pizzaDataList.Add(pizzaDataTmp);

            pizzaDataTmp.Name = "Сырная";
            pizzaDataTmp.Price = 289;
            pizzaDataList.Add(pizzaDataTmp);

            pizzaDataTmp.Name = "Пепперони фреш";
            pizzaDataList.Add(pizzaDataTmp);
        }

        public bool isCartEmpty()
        {
            bool isCartEmpty = true;
            foreach (var pizza in pizzaDataList)
                if (pizza.Count > 0) { isCartEmpty = false; }
            return isCartEmpty;
        }

        public void ChangeCount(int NumOfPizza, int Value)
        { 
            var tmp = pizzaDataList[NumOfPizza - 1];
            tmp.Count += Value;
            if (tmp.Count < 0) { tmp.Count = 0; }
            pizzaDataList[NumOfPizza - 1] = tmp;
        }

        public int GetCount(int NumOfPizza) 
        {
            return pizzaDataList[NumOfPizza - 1].Count;
        }

        public int GetSumOfPurchase()
        {
            var sum = 0;
            foreach (var pizza in pizzaDataList)
            {
                sum += pizza.Price * pizza.Count;
            }
            return sum;
        }
    }
}
