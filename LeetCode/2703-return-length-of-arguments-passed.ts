/* https://leetcode.com/problems/return-length-of-arguments-passed/description/ */

type JSONValue = null | boolean | number | string | JSONValue[] | { [key: string]: JSONValue };

function argumentsLength(...args: JSONValue[]): number {
    return args.length;
};

/**
 * argumentsLength(1, 2, 3); // 3
 */