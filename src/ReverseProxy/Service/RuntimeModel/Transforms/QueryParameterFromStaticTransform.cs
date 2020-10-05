// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.ReverseProxy.Service.RuntimeModel.Transforms
{
    internal class QueryParameterFromStaticTransform : QueryParameterTransform
    {
        public QueryParameterFromStaticTransform(QueryStringTransformMode mode, string key, string value)
            : base(mode, key)
        {
            Value = value;
        }

        internal string Value { get; }

        protected override string GetValue(RequestParametersTransformContext context)
        {
            return Value;
        }
    }
}