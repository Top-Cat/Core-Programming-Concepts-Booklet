/*Part of a java program i wrote demonstrating creating a cube,
without top or bottom (although extending to this would be easy),
in 3d space														*/

int xs = 643;
int zs = 198;
for (int i = 1; i < 6; i++) {
	for (int j = 0; j < 5; j++) {
		for (int k = 0; k < 5; k++) {
			if (j == 0 || j == 4 || k == 0 || k == 4) {
				attacker.getWorld().getBlockAt(j + xs, i, k + zs).setType(Material.OBSIDIAN);
			}
		}
	}
}