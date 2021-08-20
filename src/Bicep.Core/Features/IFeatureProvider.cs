// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Bicep.Core.Features
{
    public interface IFeatureProvider
    {
        public bool RegistryEnabled { get; }
    }
}
