﻿using System;
using Bit.Core.Models.Table;
using Bit.Core.Models.Data;

namespace Bit.Core.Models.Api
{
    public class CollectionResponseModel : ResponseModel
    {
        public CollectionResponseModel(Collection collection, string obj = "collection")
            : base(obj)
        {
            if(collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Id = collection.Id.ToString();
            OrganizationId = collection.OrganizationId.ToString();
            Name = collection.Name;
        }

        public CollectionResponseModel(CollectionUserCollectionDetails collection, string obj = "collection")
            : base(obj)
        {
            if(collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            Id = collection.Id.ToString();
            OrganizationId = collection.OrganizationId.ToString();
            Name = collection.Name;
        }

        public string Id { get; set; }
        public string OrganizationId { get; set; }
        public string Name { get; set; }
    }

    public class CollectionUserDetailsResponseModel : CollectionResponseModel
    {
        public CollectionUserDetailsResponseModel(CollectionUserCollectionDetails collection)
            : base(collection, "collectionUserDetails")
        {
            ReadOnly = collection.ReadOnly;
        }

        public bool ReadOnly { get; set; }
    }
}