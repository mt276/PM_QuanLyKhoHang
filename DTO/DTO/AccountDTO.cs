using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class AccountDTO
    {

            public AccountDTO(int id, string userName, string password, string fullName, string address, DateTime startDate, bool del, string note)
            {
                this.ID = id;
                this.UserName = userName;
                this.Password = password;
                this.FullName = fullName;
                this.Address = address;
                this.TypeID = typeID;
                this.StartDate = startDate;
                this.Del = del;
                this.Note = note;
            }
            public AccountDTO(DataRow row)
            {
                this.ID = int.Parse(row["ID"].ToString());
                this.UserName = row["userName"].ToString();
                this.Password = row["password"].ToString();
                this.FullName = row["fullName"].ToString();
                this.Address = row["address"].ToString();
                this.TypeID = int.Parse(row["typeID"].ToString());
                this.StartDate = DateTime.Parse(row["startDate"].ToString());
                this.Del = bool.Parse(row["del"].ToString());
                this.Note = row["note"].ToString();
            }


            private int id;
            private string userName;
            private string password;
            private string fullName;
            private string address;
            private int typeID;
            private DateTime startDate;
            private bool del;
            private string note;

            public int ID { get => id; set => id = value; }
            public string UserName { get => userName; set => userName = value; }
            public string Password { get => password; set => password = value; }
            public string FullName { get => fullName; set => fullName = value; }
            public string Address { get => address; set => address = value; }
            public int TypeID { get => typeID; set => typeID = value; }
            public DateTime StartDate { get => startDate; set => startDate = value; }
            public bool Del { get => del; set => del = value; }
            public string Note { get => note; set => note = value; }
        }
}
