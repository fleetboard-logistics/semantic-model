using System;
using System.Collections.Generic;
using System.Text;
using Conizi.Model.Shared.Attributes;
using Conizi.Model.Shared.Entities;

namespace Conizi.Model.Extensions
{
    /// <summary>
    /// Extensions for schema and models
    /// </summary>
    public static class SchemaExtensions
    {
        /// <summary>
        /// Add or update conizi metadata on model instance
        /// </summary>
        /// <param name="model">The model</param>
        /// <param name="metadata">The metadata object</param>
        public static EdiMetadata AddOrUpdateMetadata(this EdiModel model, EdiMetadata metadata)
        {
            if (model.Metadata == null)
            {
                model.Metadata = metadata;
                return metadata;
            }

            model.Metadata.CreatedAt = metadata.CreatedAt ?? model.Metadata.CreatedAt;
            model.Metadata.CreatedBy = metadata.CreatedBy ?? model.Metadata.CreatedBy;
            model.Metadata.Receiver = metadata.Receiver ?? model.Metadata.Receiver;
            model.Metadata.Sender = metadata.Sender ?? model.Metadata.Sender;
            model.Metadata.TechnicalSender = metadata.TechnicalSender ?? model.Metadata.TechnicalSender;
            model.Metadata.Environment = metadata.Environment ?? model.Metadata.Environment;
            return metadata;
        }

        /// <summary>
        /// Get Metadata from model instance
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static EdiMetadata GetMetadata(this EdiModel model)
        {
            return model.Metadata;
        }
    }
}