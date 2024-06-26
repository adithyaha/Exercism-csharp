2, # Logs, Logs, Logs!

Welcome to Logs, Logs, Logs! on Exercism's C# Track.
If you need help running the tests or submitting your code, check out `HELP.md`.
If you get stuck on the exercise, check out `HINTS.md`, but try and solve it without using those first :)

## Introduction

## Enums

The C# `enum` type represents a fixed set of named constants (an enumeration). Its chief purpose is to provide a type-safe way of interacting with numeric constants, limiting the available values to a pre-defined set. A simple enum can be defined as follows:

```csharp
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
```

If not defined explicitly, enum members will automatically get assigned incrementing integer values, with the first value being zero. It is also possible to assign values explicitly:

```csharp
enum Answer
{
    Maybe = 1,
    Yes = 3,
    No = 5
}
```

## Instructions

In this exercise you'll be processing log-lines.

Each log line is a string formatted as follows: `"[<LVL>]: <MESSAGE>"`.

These are the different log levels:

- `TRC` (trace)
- `DBG` (debug)
- `INF` (info)
- `WRN` (warning)
- `ERR` (error)
- `FTL` (fatal)

You have three tasks.

## 1. Parse log level

Define a `LogLevel` enum that has six elements corresponding to the above log levels.

- `Trace`
- `Debug`
- `Info`
- `Warning`
- `Error`
- `Fatal`

Next, implement the (_static_) `LogLine.ParseLogLevel()` method to parse the log level of a log line:

```csharp
LogLine.ParseLogLevel("[INF]: File deleted")
// => LogLevel.Info
```

## 2. Support unknown log level

Unfortunately, occasionally some log lines have an unknown log level. To gracefully handle these log lines, add an `Unknown` element to the `LogLevel` enum which should be returned when parsing an unknown log level:

```csharp
LogLine.ParseLogLevel("[XYZ]: Overly specific, out of context message")
// => LogLevel.Unknown
```

## 3. Convert log line to short format

The log level of a log line is quite verbose. To reduce the disk space needed to store the log lines, a short format is developed: `"[<ENCODED_LEVEL>]:<MESSAGE>"`.

The encoded log level is a simple mapping of a log level to a number:

- `Unknown` - `0`
- `Trace` - `1`
- `Debug` - `2`
- `Info` - `4`
- `Warning` - `5`
- `Error` - `6`
- `Fatal` - `42`

Implement the (_static_) `LogLine.OutputForShortLog()` method that can output the shortened log line format:

```csharp
LogLine.OutputForShortLog(LogLevel.Error, "Stack overflow")
// => "6:Stack overflow"
```

## Source

### Created by

- @ErikSchierboom

### Contributed to by

- @valentin-p
- @yzAlvin