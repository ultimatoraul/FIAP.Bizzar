using SQLite;
using System;

namespace FIAP.Bizzar.Models
{
    public class BaseModel
    {
        private Guid id;
        [PrimaryKey, AutoIncrement]
        public Guid Id
        {
            get { return id; }
            set
            {
                if (id != value)
                    id = value;
            }
        }
    }
}
