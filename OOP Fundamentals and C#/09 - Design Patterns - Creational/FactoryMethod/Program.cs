using FactoryMethod.Creators;

TransportCreator shipFactory = new ShipCreator();
TransportCreator truckFactory = new TruckCreator();
TransportCreator transporterFactory = new VehicleCreator();

truckFactory.DispatchTransport(10);
shipFactory.DispatchTransport(30);
transporterFactory.DispatchTransport(100);
truckFactory.DispatchTransport(100);

Console.ReadLine();