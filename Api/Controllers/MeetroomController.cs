using Domain.InputModels;
using IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace Api.Controllers
{
    /// <summary>
    /// 会议室管理
    /// </summary>
    [ApiController]
    public class MeetroomController 
    {
        
        private readonly IServiceDB Db;
        public MeetroomController(IServiceDB Db)
        {
            this.Db = Db;
        }
        /// <summary> 
        /// 会议室新增
        /// </summary>                                                                           
        /// <param name="RoomNewModel"></param>
        [HttpPost, Route("api/RoomNewModel")]
        public int StartDeparture(RoomNewModel roomNewModel)
        {
           return  Db.RoomNewModeladd(roomNewModel);
        }
        /// <summary>
        /// 会议室预定
        /// </summary>
        /// <param name="RoomreservationModel"></param>
        [HttpPost, Route("api/RoomreservationModel")]
        public int StartRoomreservationModel(RoomreservationModel roomreservationModel)
        {
            return Db.RoomreservationModeladd(roomreservationModel);
        }

    }
}
