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
- **Knuth-Morris-Pratt** algorithm uses this approach.
2. Suffix searching
- Search is done backwards along the search window, readingthe longest suffix of the window that is also a suffix of the pattern.
- **Boyer-Moore** algorithm uses this approach.
3. Factor searching
- Search is done backwards in the search window, looking for the longest suffix of the window that is also a factor of the pattern.
- **BNDM** is an example of such approach. 

## BNDM
- **_bit-parallelism_** is used to perform the factor search.
- Uses less memory compared to **_Backward Dawg Matching_** which uses **_Suffix automaton_** for factor searching.
