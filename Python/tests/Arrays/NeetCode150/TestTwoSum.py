import pytest
from leetcode.Arrays.NeetCode150.TwoSums import twoSum


@pytest.mark.parametrize("array, target, expected", [
    ([15, 11, 7, 2], 9, [2, 3]),
    ([2, 7, 11, 15], 9, [0, 1]),
    ([3, 2, 4], 6, [1, 2]),
    ([3, 4, 2], 6, [1, 2]),
    ([3, 3], 6, [0, 1]),
    ([], 0, []),
    ([1], 1, []),
    ([2 ** 31 - 1, -2 ** 31], (2 ** 31 - 1) + (-2 ** 31), [0, 1]),
    ([-1, -2, -3, -4, -5], -8, [2, 4])
])
def test_solution(array, target, expected):
    assert twoSum(array, target) == expected
