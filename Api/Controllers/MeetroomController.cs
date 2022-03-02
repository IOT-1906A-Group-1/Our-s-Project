using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.InputModels;
using Model;

namespace Api.Controllers
{
    /// <summary>
    /// 会议室管理
    /// </summary>
    [ApiController]
    public class MeetroomController : BaseController
    {
        public MeetroomController(IConfiguration configuration) : base(configuration)
        {

        }
        /// <summary> 
        /// 会议室新增
        /// </summary>                                                                           
        /// <param name="InputRoomNewModel"></param>
        [HttpPost, Route("api/startRoomNewModel")]
        public int StartDeparture(BPMRoomNewModel bPMRoomNewModel)
        {
            var xml = CollectionToSqlXml<RoomNewModel>(bPMRoomNewModel.RoomNewModel);
            StartProccess(xml, bPMRoomNewModel);
            return 1;
        }
        /// <summary>
        /// 会议室预定
        /// </summary>
        /// <param name="InputRoomreservationModel"></param>
        [HttpPost, Route("api/startRoomreservationModel")]
        public int StartRoomreservationModel(BPMRoomreservationModel bPMRoomreservationModel)
        {
            var xml = CollectionToSqlXml<RoomreservationModel>(bPMRoomreservationModel.RoomreservationModel);
            StartProccess(xml, bPMRoomreservationModel);
            return 1;
        }
    }
}
