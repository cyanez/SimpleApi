using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Models {
  public class Employee {
    private string name;
    public string Name {
      get => name;
      set => name = value;
    }

    public string SayHello() {
      return $"hello {name}";
    }

  }
}
