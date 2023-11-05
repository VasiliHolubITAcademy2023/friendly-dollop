namespace DigitalTransition.FriendlyDollop.BL.Common.Contracts
{
    /// <summary>
    /// Abstraction for all type of business models.
    /// </summary>
    public abstract class ModelBase : IEqualityComparer<ModelBase>, IEquatable<ModelBase>, IIdentifier, IName
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Model name.
        /// </summary>
        public string Name { get; init; }

        public bool Equals(ModelBase? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id && Name == other.Name;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ModelBase)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

        public bool Equals(ModelBase x, ModelBase y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode(ModelBase obj)
        {
            return HashCode.Combine(obj.Id, obj.Name);
        }
    }
}
