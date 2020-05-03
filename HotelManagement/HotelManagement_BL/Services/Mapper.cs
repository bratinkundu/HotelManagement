using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_BL.Services
{
    class Mapper
    {
        public static DestinationType Map<SourceType, DestinationType>(SourceType Source)
        {

            MapperConfiguration MConfig = new MapperConfiguration(config => {
                config.CreateMap<SourceType, DestinationType>();
            });

            return (DestinationType)
                    Convert
                    .ChangeType(
                        MConfig
                        .CreateMapper()
                        .Map<SourceType, DestinationType>(Source),
                        typeof(DestinationType));

        }
    }
}
