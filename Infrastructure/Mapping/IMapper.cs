using System.Collections.Generic;

namespace Infrastructure.Mapping
{
    public interface IMapper<TIn,Tout>
    {
        Tout MapFrom(TIn item);
        IEnumerable<Tout> MapFrom(IEnumerable<TIn> items);
    }
}