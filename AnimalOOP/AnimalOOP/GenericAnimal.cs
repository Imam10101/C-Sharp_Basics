using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalOOP
{
    public class GenericAnimal<T> : IGenericBehavior<T>
    {
        public string GetGenericBehavior(T obj)
        {
            string behavior = string.Empty;
            
        if (obj is Animal)
            {
                Animal a =  obj as Animal;
                switch (a.Type)
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

            
            }
        else { behavior = "Not an Animal"; }
        return behavior;
        }
    }
}
