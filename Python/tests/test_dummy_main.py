import pytest

from leetcode.main import dummy_add


@pytest.mark.parametrize("a, b, expected", [
    (1, 2, 3),
    (1.1, 2.2, pytest.approx(3.3, rel=1e-9)),
    (-1, 1, 0),
    (-1.1, 1.1, pytest.approx(0, rel=1e-9))
])
def test_dummy_add(a, b, expected):
    assert dummy_add(a, b) == expected

