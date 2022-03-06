using Domain;
using Domain.OutPutModels;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IServiceDB
    {
        string Login(InputLogin model);
        List<BPMSysOUMembers> QueryOUMembers();
        List<BPMSysOURoles> QueryOURoles();
        List<BPMSysOUs> QueryOUs();
        List<BPMInstTasks> QueryInstTasks();
        List<BPMInstProcSteps> QueryInstProcSteps();
        List<Leave> QueryLeave();
        List<Employ> QueryEmploy();
        List<Departure> QuerDeparture();
        int RoomNewModeladd(RoomNewModel m);
        int RoomreservationModeladd(RoomreservationModel m);
        List<OutPutProcurement> QueryProcurement();
        List<HRModel> QUeryHR();
        List<AssetModel> QUeryAsset();
        List<AssetborrowModel> QueryAssetborrow();
        List<AssetconnectModel> QueryAssetconnect();
        List<AssetDaModel> QUeryAssetDa();
        List<AssetDtModel> QueryAssetDt();
        List<AssetFdModel> QueryAssetFd();
    }
}
