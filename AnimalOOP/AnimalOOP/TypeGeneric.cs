using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalOOP
{
    public class TypeGeneric<T> : ITypeSpecificGenericBehavior<T>
    {
        public string GetTypeSpecificBehavior<T1>(T1 data) where T1 : Animal
        {
            string behavior = string.Empty;

         
            switch (data.Type)
            {
                case AnimalType.Harvivore:
                    behavior = "Lives on harvs/grass, four footed";
                    break;
                case AnimalType.Carnivore:
                    behavior = "Having canin, meat eater";
                    break;
                case AnimalType.Omnivore:
                    behavior = "Diverse Eater, adaptable";
                    break;
                default:
                    behavior = "Unknown Behavior";
                    break;
            }
            return behavior;
        }
    }
}
