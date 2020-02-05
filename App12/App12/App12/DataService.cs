using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    public class DataService
    {
        private Detailstuff _oldProduct;
        public List<Detailstuff> Items { get; set; }
        public DataService()
        {
            Items = new List<Detailstuff>
            {
                  new Detailstuff
               {
               Name = "abc",
               Source = "cheese_1.jpg",
               Comment = "This is good",
               Rating = true,
                Save = false
           },
            new Detailstuff
            {
                Name = "efg",
                Source = "cheese_2.jpg",
                Comment = "This is good",
               Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "hij",
                Source = "cheese_3.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "Lmn",
                Source = "cheese_4.jpg",
                Comment = "This is good",
               Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "abc",
                Source = "cheese_1.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "efg",
                Source = "cheese_2.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "hij",
                Source = "cheese_3.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
             new Detailstuff
             {
                Name = "Lmn",
                Source = "cheese_4.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "abc",
                Source = "cheese_1.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "efg",
                Source = "cheese_2.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "hij",
                Source = "cheese_3.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "Lmn",
                Source = "cheese_4.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
           new Detailstuff
           {
                Name = "abc",
                Source = "cheese_1.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "efg",
                Source = "cheese_2.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
               new Detailstuff
               {
                Name = "hij",
                Source = "cheese_3.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            },
            new Detailstuff
            {
                Name = "Lmn",
                Source = "cheese_4.jpg",
                Comment = "This is good",
                Rating = true,
                Save = false
            }
            };



        }
        public async Task<List<Detailstuff>> GetItemsAsync(int pageIndex, int pageSize)

        {

            await Task.Delay(2000);



            return Items.Skip(pageIndex * pageSize).Take(pageSize).ToList();

        }


        public void HideorShow(Detailstuff product)
        {
            if (_oldProduct == product)
            {
                product.Save = !product.Save;
                UpdateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    _oldProduct.Save = false;
                    UpdateProducts(_oldProduct);

                }
                product.Save = true;
                UpdateProducts(product);
            }
            _oldProduct = product;

        }
        
        private void UpdateProducts(Detailstuff product)
        {
            var index = Items.IndexOf(product);
            Items.Remove(product);
            Items.Insert(index, product);
        }
    }
}
