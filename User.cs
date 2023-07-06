using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Enum
{
    internal class User
    {
        public string name;
        public int id;
        public Gender gender;
        public CarType carType;

        public User(string name, int id, Gender gender, CarType carType)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.carType = carType;
        }
    }
    
    enum Gender
    {
        MALE,
        FEMALE,
        OTHER
    }
    enum CarType
    {
        [Description ("This is basic")]
        BASIC = 100,
        [Description("This is Permium")]
        PERMIUM = 200,
        [Description("This is Van")]
        VAN = 300,
        [Description("This is Ultra Permium")]
        ULTRA_PERMIUM = 400,
        [Description("This is MotorCycle")]
        MOTORCYCLE = 50
    }
    
}
