using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenSMKN8Mobile.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Attributes
    {
        public string name { get; set; }
        public string description { get; set; }
        public Life life { get; set; }
        public MaleWeight male_weight { get; set; }
        public FemaleWeight female_weight { get; set; }
        public bool hypoallergenic { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class FemaleWeight
    {
        public int max { get; set; }
        public int min { get; set; }
    }

    public class Group
    {
        public Data data { get; set; }
    }

    public class Life
    {
        public int max { get; set; }
        public int min { get; set; }
    }

    public class MaleWeight
    {
        public int max { get; set; }
        public int min { get; set; }
    }

    public class Relationships
    {
        public Group group { get; set; }
    }

    public class Breed
    {
        public string id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
        public Relationships relationships { get; set; }
    }


    public class BreadResponse
    {
        public List<Breed> Data { get; set; }
    }

}
