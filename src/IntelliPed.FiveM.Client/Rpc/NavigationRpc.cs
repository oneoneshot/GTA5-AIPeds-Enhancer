using CitizenFX.Core;
using CitizenFX.Core.Native;
using FxMediator.Client;
using IntelliPed.FiveM.Shared.Requests.Navigation;
using System.Threading.Tasks;

namespace IntelliPed.FiveM.Client.Rpc;

public class NavigationRpc : BaseScript
{
    private readonly ClientMediator _mediator = new();

    public NavigationRpc()
    {
        _mediator.AddRequestHandler<MoveToPositionRpcRequest>(OnMoveToPosition);
    }

    private static async Ta