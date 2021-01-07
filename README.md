# Base36

![Build](https://github.com/Atulin/Base36/workflows/Build/badge.svg)
![Test](https://github.com/Atulin/Base36/workflows/Test/badge.svg)
![Publish](https://github.com/Atulin/Base36/workflows/Publish/badge.svg)

## Usage

### Encoding

```cs
var base36 = Base36.Encode(740_512_952);
```

```cs
var base36 = 4_324_234_535.ToBase36();
```

### Decoding

```cs
var num = Base36.Decode("h2398f");
```

```cs
var num = "73fs34".FromBase36();
```

## Method signatures

```cs
public static string Encode(ulong input);
public static string ToBase36(this ulong input);

public static ulong Decode(string input);
public static ulong FromBase36(this string input);
```