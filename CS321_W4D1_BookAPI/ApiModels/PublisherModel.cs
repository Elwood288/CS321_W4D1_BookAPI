using System;
using System.Collections.Generic;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public class PublisherModel
    {
        // TODO: fill in publisher properties. can be same as Publisher model.
        public int Id { get; set; }
        public string Name { get; set; }
        public int FoundedYear { get; set; }
        public string CountryOfOrigin { get; set; }
        public string HeadQuartersLocation { get; set; }
        public ICollection<BookModel> Books { get; set; }
    }
}

