﻿namespace CreationalPatterns.FactoryMethod;

public interface IDeliversFood
{
    public Task Deliver(int orderId);
}
