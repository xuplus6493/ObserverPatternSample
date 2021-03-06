﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class WeatherData : ISubject
  {
    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
      observers = new List<IObserver>();
    }

    public void notifyObserver()
    {
      foreach(IObserver observer in observers)
      {
        observer.update(temperature,  humidity,  pressure);
      }
    }

    public void registerObserver(IObserver o)
    {
      observers.Add(o);
    }

    public void removeObserver(IObserver o)
    {
      observers.Remove(o);
    }

    public void setMeasurements(float temperature, float humidity, float pressure)
    {
      this.temperature = temperature;
      this.humidity = humidity;
      this.pressure = pressure;
      notifyObserver();
    }
  }
}
