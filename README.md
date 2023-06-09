# Lisztomania

###### The song Lisztomania, by Phoenix, is one of my favorites. I named this project after it because initially, I was going to essentially be making a set of extension methods for the List class, but then reworked that idea into the existing "inventory/item/crafting-ish system" that it is now. I kept the name because it sounds nice and is fairly unique (and available on Nuget).

Right now, this is the basic structure and idea, and has no implementation. This is nowhere close to the final product. API is below. This will be both a functional product, and a practice project for me to get used to tooling such as automatic deployment to Nuget, corporate-style documentation and code, using Github better (actually using its features) and being a better programmer.

THIS DOES NOT WORK YET. I will be developing this in my free time as time goes on. I'll get a better README structure someday :cry:

License: This repository is dedicated to the public domain.

## API

### `Item`

#### Usage
```cs
Item inventory = new Item();
```

#### API
```cs
namespace Lisztomania;

public class Item
{

}
```

### `Stack<T> where T : Item`

#### Usage
```cs
class Ball : Item
{
	/* ... */
};
Stack<Ball> ball = new Stack<Ball>();
```

#### API
```cs
namespace Lisztomania;

public class Stack<T> where T : Item
{

}
```

### `Inventory`

#### Usage
```cs
Inventory inventory = new Inventory();
```

#### API
```cs
namespace Lisztomania;

public class Inventory
{

}
```