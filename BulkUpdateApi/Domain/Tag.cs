using System;

namespace BulkUpdateApi.Domain
{
    public class Tag
    {
        public Tag(Id<int> id, String50 value)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            if (value == null) throw new ArgumentNullException(nameof(value));

            Id = id;
            Value = value;
        }

        public Id<int> Id { get; private set; }
        public String50 Value { get; private set; }
    }
}