
# Word Finder

#### By Cameron Anderson

## Description
Counts the number of times each word appears in a given string.

## Specifications

- Use View to obtain input text from the user
  - Demonstrate ability to gather and store input
    - Example input: "This is a string which is long."
    - Example output: "This is a string which is long."
    
- Validate user input
  - Show that input is invalid for an empty string.
    - Example input: ""
    - Example output: isValid = false;
  - Show that input is valid for a non empty string.
    - Example input: "asdkfni3i7uhl{}:"
    - Example output: isValid = true;
    
- Loop through input string, splitting it into a list of individual words. Words will split at spaces and punctuation (except for "-" and "'")
  - Demonstrate splitting on spaces and punctuation
    - Example input: "This is a string which is long."
    - Example output: ["This", "is", "a", "string", "which", "is", "long"]
  - Demonstrate ignoring "-" and "'" on splitting
    - Example input: "I can't wait to turn twenty-four!"
    - Example output: ["I", "can't", "wait", "to", "turn", "twenty-four"]
    
- For each word, convert to lower case.
  - Demonstrate capitalized word changing to lower case.
    - Example input: "WoW"
    - Example output: "wow"
    
- Use words to build a word counter dictionary. If the dictionary contains the word, increment its counter, else add the word with a count of 1.
  - Demonstrate incrementing an existing word
    - Example input: {"a"=2, "the"=3, "helloworld"=1}, "helloworld"
    - Example output: {"a"=2, "the"=3, "helloworld"=2}
  - Demonstrate adding a new word
    - Example input: {"a"=2, "the"=3, "helloworld"=1}, "goodbye"
    - Example output: {"a"=2, "the"=3, "helloworld"=1, "goodbye"=1}
    
- Use dictionary keys to create a list of all words sorted by their counts.
  - Show a dictionary sorted into a list.
    - Example input: {"a"=2, "the"=3, "helloworld"=1}
    - Example output: ["the", "a", "helloworld"]
    
- Allow users to either see couts for all words, or see the count for a specific word
  - show a list of all words and their counts listed in view
    - Example input: {"a"=2, "the"=3, "helloworld"=1}, ["the", "a", "helloworld"]
    - Example output: 
      - 'the' was found 3 times.
      - 'a' was found 2 times.
      - 'helloworld' was found 1 time.
  - a single word and its count
    - Example input: {"a"=2, "the"=3, "helloworld"=1}, "the"
    - Example output: 3


## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/camander321/WordFinder.git'.
* run the command 'dotnet restore' to download the necessary packages.
* run the command 'dotnet run' to build and run the server on localhost.
* use your preferred web browser to navigate to localhost:5000


## Support and contact details

* contact the author at chamburg321@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Cameron Anderson

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.