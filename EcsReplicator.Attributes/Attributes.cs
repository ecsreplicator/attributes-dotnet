/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Peter Bjorklund. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;

namespace EcsReplicator.Attributes
{
    public enum ReplicateMode
    {
        None,
        Predictor,
        Ghost,
        All,
    }

    [AttributeUsage(AttributeTargets.Struct)]
    public sealed class ReplicateComponentAttribute : Attribute
    {
        public ReplicateMode Mode { get; set; } = ReplicateMode.All;
    }

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class BitSerializerAttribute : Attribute
    {
    }


    [AttributeUsage(AttributeTargets.Field)]
    public sealed class ReplicateAttribute : Attribute
    {

    }
}
