using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D1_BookAPI.ApiModels
{
    public static class AuthorMappingExtensions
    {

        public static AuthorModel ToApiModel(this Author author)
        {
            return new AuthorModel
            {
                // TODO: map Author properties to corresponding AuthorModel properties
                Id = author.Id,
                BirthDate = author.BirthDate,
                FirstName = author.FirstName,
                LastName = author.LastName,
            };
        }

        public static Author ToDomainModel(this AuthorModel authorModel)
        {
            return new Author
            {
                // TODO: map AuthorModel properties to corresponding Author props
                Id = authorModel.Id,
                BirthDate = authorModel.BirthDate,
                FirstName = authorModel.FirstName,
                LastName = authorModel.LastName,
            };
        }

        public static IEnumerable<AuthorModel> ToApiModels(this IEnumerable<Author> authors)
        {
            return authors.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Author> ToDomainModel(this IEnumerable<AuthorModel> authorModels)
        {
            return authorModels.Select(a => a.ToDomainModel());
        }
    }
}
