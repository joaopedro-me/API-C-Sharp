using System;

namespace BaseModel
{
    public class ModelBase
    {
        public Guid Id { get; set; }

        public static List<BaseModel> lista = new List<BaseModel>
        {

            new List 
            {
                Id = 1,
                Name = "Script01"
        
            },

            new List 
            {
                Id = 2,
                Name = "Script02"
           
            }

        };
    }
}





