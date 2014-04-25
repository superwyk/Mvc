﻿namespace Microsoft.AspNet.Mvc.ModelBinding
{
    public class ModelClientValidationRangeRule : ModelClientValidationRule
    {
        private const string RangeValidationType = "range";
        private const string MinValidationParameter = "min";
        private const string MaxValidationParameter = "max";

        public ModelClientValidationRangeRule([NotNull] string errorMessage, 
                                              [NotNull] object minValue, 
                                              [NotNull] object maxValue)
            : base(RangeValidationType, errorMessage)
        {
            ValidationParameters[MinValidationParameter] = minValue;
            ValidationParameters[MaxValidationParameter] = maxValue;
        }
    }
}
