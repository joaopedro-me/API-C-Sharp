namespace Users{
 
    public class User : ModelBase
    {
        public String Name { get; set; }

        public String Password { get; set; }

        public String HistoricUser { get; set; }

        public Datetime Datecreatecount { get; set; }
    }
}
