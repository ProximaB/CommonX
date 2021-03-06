﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommonX.Mapster
{
    /// <summary>
    ///     From Dto to Entity, Use on Dtos
    /// </summary>
    /// <seealso cref="AutoMapAttributeBase" />
    public class AutoMapToAttribute : AutoMapAttributeBase
    {
        public AutoMapToAttribute(params Type[] targetTypes)
            : base(targetTypes)
        {
        }

        public override void CreateMap(TypeAdapterConfig configuration, Type source)
        {
            if (TargetTypes.IsNullOrEmpty())
            {
                return;
            }

            foreach (Type destination in TargetTypes)
            {
                configuration.NewConfig(source, destination);
            }
        }
    }
}
