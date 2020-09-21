# Circle Overlap Problem
This is a basic application to determine whether two circles overlap and calculates the overlapped area.

## Run
Run the program using:
```
dotnet run -p CircleOverlap -- <numbers>
```

With these inputs (unit circle at origin + unit circle at (1,1))
```
dotnet run -p CircleOverlap -- 0 0 1 0 1 1
```
you get:
```
HasOverlap: True
Area: 2,960420506177634
InnerDistance: 1
OuterDistance: 0
```

## Help
```
dotnet run -p CircleOverlap -- --help
```

## Tests
Run 
```powershell
dotnet test
```

to run the tests