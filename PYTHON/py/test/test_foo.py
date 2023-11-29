from src.foo import FooCls
import unittest


class FooTest(unittest.TestCase):

    def test(self):
        f = FooCls()
        f.foo()
        f.bar(1)
        self.assertEqual(f.baz(1), 42)
