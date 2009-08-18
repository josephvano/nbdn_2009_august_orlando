using System;

namespace nothinbutdotnetprep.collections
{
    public class ProductionStudio : IEquatable<ProductionStudio>
    {
        public static readonly ProductionStudio MGM = new ProductionStudio();
        public static readonly ProductionStudio Paramount = new ProductionStudio();
        public static readonly ProductionStudio Universal = new ProductionStudio();
        public static readonly ProductionStudio Pixar = new ProductionStudio();
        public static readonly ProductionStudio Disney = new ProductionStudio();
        public static readonly ProductionStudio Dreamworks = new ProductionStudio();

        public bool Equals(ProductionStudio other) { throw new NotImplementedException(); }

    }
}