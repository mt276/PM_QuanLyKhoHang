using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTO
{
    public class TypeActDTO
    {

        public TypeActDTO(int id, string name, bool del, string note)
        {
            this.ID = id;
            this.Name = name;
            this.Del = del;
            this.Note = note;
        }
        public TypeActDTO(DataRow row)
        {
            this.ID = int.Parse(row["ID"].ToString());
            this.Name = row["name"].ToString();
            this.Del = bool.Parse(row["del"].ToString());
            this.Note = row["note"].ToString();
        }


        private int id;
        private string name;
        private bool del;
        private string note;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Del { get => del; set => del = value; }
        public string Note { get => note; set => note = value; }
    }
}
