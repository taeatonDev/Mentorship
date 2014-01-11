using System;

namespace Mentorship.Backend.Models.StronglyTypedObjects
{
    /// <summary>
    /// Strongly typed ContactId 
    /// </summary>
    [Serializable]
    public class ContactId : IEquatable<ContactId>
    {
        private readonly int _data;

        private ContactId(int data)
        {
            _data = data;
        }

        /// <summary>        
        /// The op_ implicit.        
        /// </summary>        
        /// <param name="data">
        /// The data.
        /// </param>        
        /// <returns> The strongly typed data </returns>
        public static implicit operator ContactId(int data)
        {
            return new ContactId(data);
        }

        /// <summary>        
        /// The op_ implicit.        
        /// </summary>        
        /// <param name="data">
        /// The data.
        /// </param>        
        /// <returns> The strongly typed data </returns>
        public static implicit operator int(ContactId data)
        {
            if (ReferenceEquals(data, null)) return default(int);
            return data._data;
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(ContactId other)
        {
            if (ReferenceEquals(null, other)) return _data.Equals(default(int));
            if (ReferenceEquals(this, other)) return true;
            return Equals(other._data, _data);
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. </param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return _data.Equals(default(int));
            if (ReferenceEquals(this, obj)) return true;
            var objType = obj.GetType();
            var thisType = typeof (ContactId);
            var dataTypeType = typeof (int);
            return
                (objType == thisType && Equals((ContactId) obj))
                || (objType == dataTypeType && Equals((int) obj));
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return (_data != default(int) ? _data.GetHashCode() : 0);
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(ContactId left, ContactId right)
        {
            if (ReferenceEquals(left, null)) return ReferenceEquals(right, null);
            return ReferenceEquals(left, right) || left.Equals(right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(ContactId left, ContactId right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return _data.ToString();
        }
    }
}

