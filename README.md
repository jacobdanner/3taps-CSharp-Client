# 3taps-CSharp-Client
# 3Taps CSharp/dotNet Client

(based very heavily on the 3taps-Java-Client)

### TODO:
- Test work
  - fix remaining tests
  - add more tests
  - migrate to NUnit
- JSON Api Work
  - Add proper way exclude un-initialized floats and date time fields
    - properly implement Date conversion to map from MS Iso Date format to Constants.DATE_FORMAT
- General Features
  - Make Async API
  - convenience methods for common queries
  - More examples
- Build work
  - Build outside of VS 2010
    - investigate NAnt
  - Make projects work properly in MonoDevelop
  - handle nuGet references properly


## Dependency

* .NET framework 4.0+ (it may work on earlier versions, but that's untested at the moment)
* [Json.NET](http://json.codeplex.com/) for all things Json 

## Use

To use the 3Taps CSharp/dotNet Client API Wrapper
(figure out how to do this via the dll, maybe create a nuget package)

There is a dll you can grab at:
<project_root>/obj/Debug/3taps-CShapr-Client.dll


## Building

We've only built this using MonoDevelop and VS2010, future tasks include using NAnt.

## Example

See test cases for examples.

Here's a simple one to get you started.

Message systemMessage = ThreetapsClient.getInstance().setAuthID(API_KEY).statusClient.system();

## License

Copyright (c) 2011 hmm, figure this one out

Licensed under the Apache License, Version 2.0 (the "License"); 
you may not use this file except in compliance with the License. 
You may obtain a copy of the License at 

  http://www.apache.org/licenses/LICENSE-2.0 

Unless required by applicable law or agreed to in writing, software 
distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and 
limitations under the License.