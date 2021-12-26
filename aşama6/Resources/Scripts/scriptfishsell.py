import mt2py
import mt2pyv, chrmgr, chat, item, net, player, shop
#####INTELLECTUAL PROPERTY - COPYRIGHT ALL RIGHTS RESERVED#####
BuyPaste = 0
BuyWurm = 0
BuyRod = 0
BuyFire = 0
#####INTELLECTUAL PROPERTY - COPYRIGHT ALL RIGHTS RESERVED#####
Pasteval = 27800
Wurmval = 27801
Fireval = 27600
Rodval = 27400
#####INTELLECTUAL PROPERTY - COPYRIGHT ALL RIGHTS RESERVED#####
InventorySize = hasattr(player, 'INVENTORY_PAGE_SIZE') and player.INVENTORY_PAGE_SIZE * player.INVENTORY_PAGE_COUNT or player.ZEAGII_PENTO_SYNVER * player.INVENTORY_PAGE_COUNT
RodIDs = [27400,27410,27420,27430,27440,27450,27460,27470,27480,27490,27500,27510,27520,27530,27540,27550,27560,27570,27580,27590]
def MySendShopSellPacket(slot):
	try:
		net.SendShopSellPacket(slot)
	except:
		try:
			net.SendShopSellPacket(1, slot)
		except:
			net.SendShopSellPacketNew(slot, 0, 1)

def PlayerHasRod():
	best = -1
	point = -1
	for slot in xrange(InventorySize):
		ITEM_ID = player.GetItemIndex(slot)
		if ITEM_ID == 27591: #Carbon rod
			best = slot
			break
		if ITEM_ID in RodIDs:
			if player.GetItemIndex(best) < ITEM_ID:
				best = slot
				point = player.GetItemMetinSocket(1, slot, 0)

			if player.GetItemIndex(best) == ITEM_ID:
				if point < player.GetItemMetinSocket(1, slot, 0):
					best = slot
					point = player.GetItemMetinSocket(1, slot, 0)

	equipped = player.GetItemIndex(2, item.EQUIPMENT_WEAPON)
	if best != -1 and equipped != 27591: #Carbon rod
		ITEM_ID = player.GetItemIndex(best)
		if ITEM_ID > equipped:
			return best
		elif ITEM_ID == equipped:
			if point > player.GetItemMetinSocket(2, item.EQUIPMENT_WEAPON, 0):
				return best
	if equipped in RodIDs:
		return 9999
	return best

def SellingMt2Py():
	try:
		mt2py.SetMt2Py(str(1))
		sold = False
		for j in xrange(InventorySize):
			i = InventorySize - j - 1
			vid = player.GetItemIndex(i)
			if vid == 40001 or vid == 50002 or vid == 50008 or vid == 50009 or vid == 80008:#Unbekannter Goldring, Goldring, mehrere Schluessel
				MySendShopSellPacket(i)
				sold = True

		if sold == False:
			buyneeded = False
			mt2py.SetMt2Py(str(2))
			ShopPasteSlot = -1
			ShopWurmSlot = -1
			ShopFireSlot = -1
			ShopRodSlot = -1
			for i in xrange(40):
				shopitemid = shop.GetItemID(i)
				shopitemcount = shop.GetItemCount(i)
				if shopitemid == Pasteval and shopitemcount == 50:
					ShopPasteSlot = i
				if shopitemid == Wurmval and shopitemcount == 50:
					ShopWurmSlot = i
				if shopitemid == Fireval:
					ShopFireSlot = i
				if shopitemid == Rodval:
					ShopRodSlot = i
			koedercountvalue = int(player.GetItemCountByVnum(int(Pasteval)))
			if koedercountvalue < int(BuyPaste * 50) and ShopPasteSlot > -1:
				net.SendShopBuyPacket(int(ShopPasteSlot))
				buyneeded = True
			koedercountvalue = int(player.GetItemCountByVnum(int(Wurmval)))
			if koedercountvalue < int(BuyWurm * 50) and ShopWurmSlot > -1:
				net.SendShopBuyPacket(int(ShopWurmSlot))
				buyneeded = True
			firecountvalue = int(player.GetItemCountByVnum(int(Fireval)))
			if BuyFire == 1 and firecountvalue < 1 and ShopFireSlot > -1:
				net.SendShopBuyPacket(int(ShopFireSlot))
				buyneeded = True
			if BuyRod == 1 and PlayerHasRod() == -1 and ShopRodSlot > -1:
				net.SendShopBuyPacket(int(ShopRodSlot))
				buyneeded = True

			if buyneeded == True:
				mt2py.SetMt2Py(str(1))
	except:
		useless = 1
SellingMt2Py()