using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Constants
{
    public static class DomainErrors
    {
        public static class Branch
        {
            public const string NameCannotBeEmpty = "Branch.NameCannotBeEmpty";
            public const string EmployeeAlreadyAssigned = "Branch.EmployeeAlreadyAssigned";
            public const string EmployeeNotAssigned = "Branch.EmployeeNotAssigned";
            public const string CategoryAlreadyAssigned = "Branch.CategoryAlreadyAssigned";
            public const string CategoryNotAssigned = "Branch.CategoryNotAssigned";
            public const string ProductVariantAlreadyAssigned = "Branch.ProductVariantAlreadyAssigned";
            public const string ProductVariantNotAssigned = "Branch.ProductVariantNotAssigned";
        }
        public static class BranchProductVariant
        {
            public const string PriceCanNotBeLessThanZeroOrZero = "BranchProductVariant.PriceCanNotBeLessThanZeroOrZero";
        }
        public static class Area
        {
            public const string NameCannotBeEmpty = "Area.NameCannotBeEmpty";
            public const string BranchIdCannotBeEmpty = "Area.BranchIdCannotBeEmpty";
        }
    }
}
