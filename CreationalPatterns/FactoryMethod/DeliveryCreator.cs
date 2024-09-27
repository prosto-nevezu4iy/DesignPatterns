using Newtonsoft.Json;
using RealDependencies;

namespace CreationalPatterns.FactoryMethod;

public abstract class DeliveryCreator
{
    private readonly IAmqpQueue _deliveryQueue;
    protected readonly IApplicationLogger _logger;

    public DeliveryCreator(IAmqpQueue deliveryQueue, IApplicationLogger logger)
    {
        _deliveryQueue = deliveryQueue;
        _logger = logger;
    }

    protected abstract IDeliversFood RegisterVehicle();

    public void QueueVehicleForDelivery()
    {
        var vehicle = RegisterVehicle();
        var vehiclePayload = JsonConvert.SerializeObject(vehicle);
        var queueMessage = new QueueMessage(vehiclePayload);
        _deliveryQueue.Add(queueMessage);
        _logger.LogInfo($"Queued up vehicle of type {vehicle.GetType()} for food delivery.");
    }
}
