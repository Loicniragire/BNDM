String factor pattern matching algorithm - **_Backward Nondeterministic Dawg Matching_**

## Problem definition
Find all occurrences of a given string pattern in text.

### Definitions
Given strings x, y and z, we say that:
+ *x* is a *prefix* of *xy*
+ *x* is a *suffix* of *yx*
+ *x* is a *factor* of *yxz*

### Pattern Matching approaches
Generally speaking, string pattern matching algorithms can be categorized into the following groups:
1. Prefix searching
- Search is done forward in the search window. For each position of the window, we search for the longest prefix of the window that is also a prefix of the pattern.
- [**Knuth-Morris-Pratt**](https://www.tutorialspoint.com/Knuth-Morris-Pratt-Algorithm "KMP algorithm") algorithm uses this approach.
2. Suffix searching
- Search is done backwards along the search window, readingthe longest suffix of the window that is also a suffix of the pattern.
- [**Boyer-Moore**](https://www.tutorialspoint.com/Boyer-Moore-Algorithm "Boyer-Moore algorithm") algorithm uses this approach.
3. Factor searching
- Search is done backwards in the search window, looking for the longest suffix of the window that is also a factor of the pattern.
- **BNDM** is an example of such approach. 

## BNDM
- [**_bit-parallelism_**](https://www.tutorialspoint.com/types-of-parallelism-in-processing-execution "Bit parallelism tutorial") is used to perform the factor search.
- Uses less memory compared to **_Backward Dawg Matching_** which uses [**_Suffix automaton_**](https://www.tutorialspoint.com/automata_theory/automata_theory_introduction.htm "Automata Theory") for factor searching.

#### Reference List
- Navarro, G., &amp; Raffinot, M. (2014). Flexible pattern matching in strings: Practical on-line search algorithms for texts and biological sequences (pp. 27-38). Cambridge: Cambridge University Press.
