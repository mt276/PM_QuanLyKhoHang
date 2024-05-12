using System;
using System.Data;


namespace DTO.ACK
{
    public class BillACK
    {
        public BillACK()
        {
            this.Error = error;
            this.ID = -1;
            this.State = false;
        }

        private int id;
        private bool state;
        private string error;
        private double overage;

        public int ID { get => id; set => id = value; }
        public bool State { get => state; set => state = value; }
        public string Error { get => error; set => error = value; }
        public double Overage { get => overage; set => overage = value; }
    }
}
