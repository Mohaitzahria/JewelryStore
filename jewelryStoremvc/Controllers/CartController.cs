using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace jewelryStoremvc.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepo;

        public CartController(ICartRepository cartRepo)
        {
            _cartRepo = cartRepo;
        }

        public async Task<IActionResult> AddItem(int jewelryId, int qty = 1, int redirect = 0)
        {
            try
            {
                var cartCount = await _cartRepo.AddItem(jewelryId, qty);
                if (redirect == 0)
                    return Ok(cartCount);
                return RedirectToAction("GetUserCart");
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to add item to cart. {ex.Message}");
            }
        }

        public async Task<IActionResult> RemoveItem(int jewelryId)
        {
            try
            {
                var cartCount = await _cartRepo.RemoveItem(jewelryId);
                return RedirectToAction("GetUserCart");
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to remove item from cart. {ex.Message}");
            }
        }

        public async Task<IActionResult> GetUserCart()
        {
            try
            {
                var cart = await _cartRepo.GetUserCart();
                return View(cart);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to retrieve user cart. {ex.Message}");
            }
        }

        public async Task<IActionResult> GetTotalItemInCart()
        {
            try
            {
                int cartItem = await _cartRepo.GetCartItemCount();
                return Ok(cartItem);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to get total items in cart. {ex.Message}");
            }
        }

        public async Task<IActionResult> Checkout()
        {
            try
            {
                bool isCheckedOut = await _cartRepo.DoCheckout();
                if (!isCheckedOut)
                    throw new Exception("Something happened on the server side during checkout.");
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return BadRequest($"Checkout failed. {ex.Message}");
            }
        }
    }
}
