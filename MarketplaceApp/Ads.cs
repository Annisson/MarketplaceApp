using System;
using System.Collections.Generic;
using System.Text;

namespace MarketplaceApp
{
    public class Ads
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }

        public Ads(string title, string category, string price, string description, int userID, DateTime date)
        {
            this.Title = title;
            this.Category = category;
            this.Price = price;
            this.Description = description;
            this.UserID = userID;
            this.Date = date;
        }

        public string AdsCheckFields() // kollar att alla fält är ifyllda
        {
            string checkedInfo = "";
            Form1 form1 = new Form1();

            if (Title == "" || Category == "Select Category" || Price == "" || Description == "")
            {
                string[] infoMessage = new string[4];
                for (int i = 0; i < infoMessage.Length; i++)
                {
                    if (Title == "")
                    {
                        infoMessage[i] += "\nTitle";
                    }
                    if (Category == "Select Category")
                    {
                        infoMessage[i] += "\nCategory";
                    }
                    if (Price == "")
                    {
                        infoMessage[i] += "\nPrice";
                    }
                    if (Description == "")
                    {
                        infoMessage[i] += "\nDescription";
                    }
                    return "\n" + infoMessage[i];
                }
            }
            return checkedInfo;
        }



    }
}
